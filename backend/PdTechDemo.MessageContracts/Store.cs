using System;

namespace PdTechDemo.MessageContracts
{
    // e.g. Good Games Brisbane.
    public class Store
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }
    }
}
