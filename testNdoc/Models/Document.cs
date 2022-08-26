using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

#nullable disable

namespace testNdoc
{
    public partial class Document
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }

        public virtual Section Section { get; set; }
    }
}
