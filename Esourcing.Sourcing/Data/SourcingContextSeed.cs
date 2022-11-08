using Esourcing.Sourcing.Entities;
using MongoDB.Driver;

namespace Esourcing.Sourcing.Data
{
    public class SourcingContextSeed
    {
        public static void SeedData(IMongoCollection<Auction> auctionCollection)
        {
            bool exists = auctionCollection.Find(p=> true).Any();
            if (!exists)
            {
                auctionCollection.InsertManyAsync(GetPreconfiguredAuctions());
            }
        }
        private static IEnumerable<Auction> GetPreconfiguredAuctions()
        {
            return new List<Auction>()
            {
                new Auction()
                {
                    Name = "Auction 1",
                    Description = "Auction Desc 1",
                    CreatedAt = DateTime.Now,
                    StartedAt = DateTime.Now,
                    FinishedAt = DateTime.Now,
                    ProductId = "60093337093d7352d5467341",
                    InculudedSellers = new List<string>()
                    {
                        "seller1@test.com",
                        "seller2@test.com",
                        "seller3@test.com"
                    },
                    Quantity =5,
                    Status = (int)Status.Active
                },
                new Auction()
                {
                    Name = "Auction 2",
                    Description = "Auction Desc 2",
                    CreatedAt = DateTime.Now,
                    StartedAt = DateTime.Now,
                    FinishedAt = DateTime.Now,
                    ProductId = "60093337093d7352d5467341",
                    InculudedSellers = new List<string>()
                    {
                        "seller1@test.com",
                        "seller2@test.com",
                        "seller3@test.com"
                    },
                    Quantity =5,
                    Status = (int)Status.Active
                },
                new Auction()
                {
                    Name = "Auction 3",
                    Description = "Auction Desc 3",
                    CreatedAt = DateTime.Now,
                    StartedAt = DateTime.Now,
                    FinishedAt = DateTime.Now,
                    ProductId = "60093337093d7352d5467341",
                    InculudedSellers = new List<string>()
                    {
                        "seller1@test.com",
                        "seller2@test.com",
                        "seller3@test.com"
                    },
                    Quantity =5,
                    Status = (int)Status.Active
                }
            };
        }
    }
}
