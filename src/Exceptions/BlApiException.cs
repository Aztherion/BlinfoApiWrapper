using System;
using BlInfoApiWrapper.Dto;

namespace BlInfoApiWrapper.Exceptions
{
    public class BlApiException : Exception
    {
        public string ApiSource { get; }
        public BlApiException(ExceptionItem item) : base(item.Message)
        {
            ApiSource = item.Exception;
        }
    }
}
