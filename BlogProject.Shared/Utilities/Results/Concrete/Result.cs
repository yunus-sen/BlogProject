using BlogProject.Shared.Utilities.Results.Abstract;
using BlogProject.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Shared.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result(ResultStatus ResultStatus)
        {
            this.ResultStatus = ResultStatus;
        }
        public Result(ResultStatus ResultStatus, string Message)
        {
            this.ResultStatus = ResultStatus;
            this.Message = Message;
        }

        public Result(ResultStatus ResultStatus, string Message, Exception Exception)
        {
            this.ResultStatus = ResultStatus;
            this.Message = Message;
            this.Exception = Exception;
        }
        public ResultStatus ResultStatus { get; }

        public string Message { get; }

        public Exception Exception { get; }
    }
}
