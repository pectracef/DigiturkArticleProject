using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiturkArticleProject.API.Logger
{
    public class Logger : ILogger
    {
        IWebHostEnvironment _hostingEnvironment;
        public Logger(IWebHostEnvironment hostingEnvironment) => _hostingEnvironment = hostingEnvironment;
        public IDisposable BeginScope<TState>(TState state) => null;
        public bool IsEnabled(LogLevel logLevel) => true;
        public async void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            string filePath = $"{_hostingEnvironment.ContentRootPath}/log.txt";
            using (var fileStream = File.Open(filePath, FileMode.Append, FileAccess.Write, FileShare.Write))
            {
                var logMessage = $"Log Level : {logLevel.ToString()} | Event ID : {eventId.Id} | Event Name : {eventId.Name} | Formatter : {formatter(state, exception)} {Environment.NewLine}";
                byte[] logMessageByteArray = Encoding.UTF8.GetBytes(logMessage);
                await fileStream.WriteAsync(logMessageByteArray);
                fileStream.Close();
                fileStream.Dispose();
            }
        }
    }
}
