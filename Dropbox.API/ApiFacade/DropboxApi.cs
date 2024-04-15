using Dropbox.API.Builders;
using Dropbox.API.Extensions;
using Dropbox.API.Models;
using Dropbox.Core.DataConstants;
using Newtonsoft.Json;

namespace Dropbox.API.ApiFacade
{
    public class DropboxApi
    {
        public RequestBuilder request;
        public DropboxApi()
        {
            request = new RequestBuilder(BaseApiConstance.ServiceUrl);
        }

        public ApiResponse GetFilesList()
        {
            const string url = "files/list_folder";
            var requestBody = JsonConvert.SerializeObject(new Base());
            return request.Method(HttpMethod.Post).Uri(url).WithBody(requestBody).Execute();
        }

        public ApiResponse CreateFolder(Base createFolder)
        {
            const string url = "files/create_folder_v2";
            var requestBody = JsonConvert.SerializeObject(createFolder);
            return request.Method(HttpMethod.Post).Uri(url).WithBody(requestBody).Execute();
        }

        public ApiResponse GetFilesListForFolder(Base folderPath)
        {
            const string url = "files/list_folder";
            var requestBody = JsonConvert.SerializeObject(folderPath);
            return request.Method(HttpMethod.Post).Uri(url).WithBody(requestBody).Execute();
        }
    }
}
