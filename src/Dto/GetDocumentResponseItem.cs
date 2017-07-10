using System;
using System.Collections.Generic;
using System.Text;

namespace BlInfoApiWrapper.Dto
{
    public class GetDocumentResponseItem
    {
        public string Name { get; set; }
        public byte[] Data { get; set; }

        public GetDocumentResponseItem()
        {
            Name = string.Empty;
        }
    }
}
