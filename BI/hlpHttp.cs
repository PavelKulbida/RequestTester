using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace BI
{
    public partial class hlpHttp
    {
        public string Method;
        public int Timeout;
        public string ContentType;
        public ICredentials Credentials;
        public Encoding EncoderRequest;
        public Encoding EncoderResponse;
        public bool AllowAutoRedirect;
        public bool KeepAlive;

        public static hlpHttp SinglInstance
        {
            get 
            {
                // DCL
                if (instance == null)
                {
                    lock (syncRoot) 
                    {
                        if (instance == null)
                        {
                            instance = new hlpHttp();
                        }
                    }
                }

                return instance;
            }
        }

        public hlpHttp()
        {
            SetDefaultHttpParam();
        }

        public void SetDefaultHttpParam()
        {
            this.Method = "POST";
            this.Timeout = 60000;
            this.ContentType = "application/x-www-form-urlencoded";
            this.Credentials = CredentialCache.DefaultCredentials;
            this.EncoderRequest = Encoding.UTF8;
            this.EncoderResponse = Encoding.UTF8;
            this.AllowAutoRedirect = false;
            this.KeepAlive = false;
        }


        public string SendPost(string url, string requestData, int timeout, Encoding encoder)
        {
            this.Timeout = timeout;
            this.EncoderRequest = encoder;
            this.EncoderResponse = encoder;

            return this.SendPost(url, requestData);
        }

        public string SendPost(string url, string requestData)
        {
            hlpAssert.IsNotNullOrEmpty(url);
            hlpAssert.IsNotNull(requestData);

            byte[] buf = this.EncoderRequest.GetBytes(requestData);

            return SendPost(url, buf);
        }

        public string SendPost(string url, byte[] requestData)
        {
            hlpAssert.IsNotNullOrEmpty(url);
            hlpAssert.IsNotNull(requestData);

            string ret = null;

            HttpWebRequest request = CreateWebRequest(url);

            if (MethodsHasBody.Contains(this.Method.ToUpper()))
            { 
                request.ContentLength = requestData.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(requestData, 0, requestData.Length);
                requestStream.Close();
            }

            WebResponse response = request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream(), EncoderResponse);
            object obj = streamReader.ReadToEnd();
            streamReader.Close();

            ret = obj.ToString();

            request = null;
            response = null;

            return ret;
        }


        public string SendHttpFile(string url, string fileName, Stream fileStream)
        {
            Dictionary<string, Stream> files = new Dictionary<string, Stream>();
            files.Add(fileName, fileStream);

            return SendHttpFile(url, files);
        }

        public string SendHttpFiles(string url, string[] pathList)
        {
            Dictionary<string, Stream> files = new Dictionary<string, Stream>();

            foreach (string file in pathList)
            {
                string fileName = Path.GetFileName(file);
                Stream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);

                files.Add(fileName, fileStream);
            }

            return SendHttpFile(url, files);
        }

        public string SendHttpFile(string url, Dictionary<string, Stream> files)
        {
            string boundary = "----------------------------" + DateTime.Now.Ticks.ToString("x");
            this.ContentType = "multipart/form-data; charset=" + this.EncoderRequest.BodyName + "; boundary=" + boundary;
            string headerTemplate = "\r\n--" + boundary + "\r\nContent-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n";

            Stream memStream = new System.IO.MemoryStream();

            foreach (KeyValuePair<string, Stream> file in files)
            {

                Stream fileStream = file.Value;
                String fileName = file.Key;
                String fileType = GetContentTypeForFile(file.Key);

                MemoryStream ms = new MemoryStream();
                StreamCopyTo(fileStream, ms);
                byte[] rez = ms.ToArray();


                string header = string.Format(headerTemplate, "userfile", fileName, fileType);
                byte[] headerbytes = this.EncoderRequest.GetBytes(header);

                memStream.Write(headerbytes, 0, headerbytes.Length);
                memStream.Write(rez, 0, rez.Length);
            }

            byte[] boundarybytes = this.EncoderRequest.GetBytes("\r\n--" + boundary);
            memStream.Write(boundarybytes, 0, boundarybytes.Length);


            memStream.Position = 0;
            byte[] tempBuffer = new byte[memStream.Length];
            memStream.Read(tempBuffer, 0, tempBuffer.Length);
            memStream.Close();

            return SendPost(url, tempBuffer);
        }

        #region private
        private static volatile hlpHttp instance;
        private readonly static object syncRoot = new Object();

        // fabric method
        private HttpWebRequest CreateWebRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = this.Method;
            request.ContentType = this.ContentType;
            request.Timeout = this.Timeout;
            request.Proxy.Credentials = this.Credentials;

            request.AllowAutoRedirect = this.AllowAutoRedirect;
            request.KeepAlive = this.KeepAlive;

            return request;
        }


        private void StreamCopyTo(Stream src, Stream dst)
        {
            byte[] buffer = new byte[4096];
            int count;
            while ((count = src.Read(buffer, 0, buffer.Length)) != 0)
                dst.Write(buffer, 0, count);
        }

        private string GetContentTypeForFile(string fileName)
        {
            string mimeType = null;

            string ext = Path.GetExtension(fileName).ToLower();
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);

            if (null != regKey && null != regKey.GetValue("Content Type"))
            {
                mimeType = regKey.GetValue("Content Type").ToString();
            }
            else
            {
                MimeTypes.TryGetValue(ext, out mimeType);
            }

            if (null == mimeType)
            {
                mimeType = "application/unknown";
            }

            return mimeType;
        }

        private IList<string> MethodsHasBody = new List<string>() 
        {
            "POST",
            "PUT",
            "PATCH"
        };
        #endregion
    }
}
