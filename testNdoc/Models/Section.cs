using System;
using System.Collections.Generic;


namespace testNdoc
{
    public  class Section
    {
        public Section()
        {
            Documents = new HashSet<Document>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
    }
}
