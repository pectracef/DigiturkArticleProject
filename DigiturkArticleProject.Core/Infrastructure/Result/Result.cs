using System;
using System.Collections.Generic;

namespace DigiturkArticleProject.Core.Infrastructure
{
    public class Result<RType> where RType : class
    {
        public bool isSuccess { get; set; }
        public string message { get; set; }
        public RType data { get; set; }
        public bool showAlert { get; set; }

        public Result(bool isSuccess, string message, bool showAlert = true)
        {
            this.isSuccess = isSuccess;
            this.message = message;
            this.showAlert = showAlert;
        }
        public Result(bool isSuccess, string message, RType data, bool showAlert = true)
        {
            Type dataType = data.GetType();
            showAlert = !(dataType.IsGenericType && dataType.GetGenericTypeDefinition() == typeof(List<>));
            this.isSuccess = isSuccess;
            this.message = message;
            this.data = data;
            this.showAlert = showAlert;
        }
    }
}
