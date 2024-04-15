using Dropbox.API.ApiFacade;
using Dropbox.API.Extensions;
using Dropbox.API.Models;
using Dropbox.Core.DataConstants;
using Dropbox.Core.Helpers;
using FluentAssertions;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;
using static Dropbox.Core.Extensions.UriExtensions;

namespace Dropbox.Tests.Steps.API
{
    [Binding]
    public class UploadFileSteps
    {
        [Given(@"I have '(.*)' file to upload")]
        public void GivenIHaveFileToUpload(string fileName)
        {
            var filePath = GetFilePath(fileName);
            File.Exists(filePath)
                .Should()
                .BeTrue($"expected {fileName} to exists with test fata files inside the {filePath}");

            ContextHelper.AddToContext("FilePath", filePath);
        }

        [When(@"I upload the file")]
        public void WhenIUploadTheFile(UploadFileDto uploadFile)
        {
            var filePath = ContextHelper.GetFromContext<string>("FilePath");
            var file = File.ReadAllBytes(filePath);
            var response = new DropboxApiContent().UploadFile(uploadFile, file);
            response.EnsureSuccessful();
            ContextHelper.AddToContext("LastApiResponse", response);
        }

        [Then(@"I should be able to get file info")]
        public void ThenIShouldBeAbleToGetFileInfo(FileResponseDto fileInfo)
        {
            var apiResponse = ContextHelper.GetFromContext<ApiResponse>("LastApiResponse");
            var actualFileInfo = apiResponse.Content<FileResponseDto>();

            actualFileInfo.Should().BeEquivalentTo(fileInfo, options => options.Including(f => f.Name));
        }

        private string GetFilePath(string fileName)
        {
            string codeBase = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)
                              + Path.DirectorySeparatorChar
                              + BaseApiConstance.DefaultFilePath;
            var uri = new UriBuilder(codeBase).Uri.Append(fileName);
            string fullPath = Path.GetFullPath(Uri.UnescapeDataString(uri.AbsolutePath));

            ScenarioContext.Current["DefaultFilePath"] = fullPath;
            return fullPath;
        }
    }
}
