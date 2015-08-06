using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using PdTechDemo.MessageContracts;

namespace PdTechDemo.Web.Controllers
{
    public class StoreController : ApiController
    {
        // Temp data structure...
        private static readonly HashSet<Store> Stores = new HashSet<Store>
        {
            new Store
            {
                Id = new Guid("a9f93717-07b1-41c4-a8a2-f223b650f22e"),
                Name = "Good Games",
                Location = "Spring Hill"
            },
            new Store
            {
                Id = new Guid("d73e5952-e5a7-4465-9dca-d9a091aef9ac"),
                Name = "Ace Comics & Games",
                Location = "Annerley"
            }
        };

        // GET: api/Store (List)
        public Store[] Get()
        {
            return Stores.ToArray();
        }

        // GET: api/Store/5 (Read)
        public Store Get(Guid id)
        {
            return Stores.SingleOrDefault(s => s.Id == id);
        }

        // POST: api/Store (Create)
        public void Post([FromBody] Store store)
        {
            Stores.Add(store); // Assuming Guid not rubbish here for now...
        }

        // PUT: api/Store/5 (Update)
        public void Put([FromBody] Store store)
        {
            var existingStore = Stores.SingleOrDefault(s => s.Id == store.Id);
            if (existingStore != null) existingStore = store;
        }

        // PATCH: api/Store/5 (Partial Update)
        public void Patch([FromBody] Store store)
        {
            // As per Put for now...
            var existingStore = Stores.SingleOrDefault(s => s.Id == store.Id);
            if (existingStore != null) existingStore = store;
        }

        // DELETE: api/Store/5 (Destroy)
        public void Delete(Guid id)
        {
            Stores.RemoveWhere(s => s.Id == id);
        }
    }
}
