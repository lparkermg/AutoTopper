using System;

namespace AutoPotter
{
    public class PotDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
        public long Balance { get; set; }
        public string Currency { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Deleted { get; set; }

        public PotDTO(string id, string name, string style, long balance, string currency, DateTime created, DateTime updated, bool deleted)
        {
            Id = id;
            Name = name;
            Style = style;
            Balance = balance;
            Currency = currency;
            Created = created;
            Updated = updated;
            Deleted = deleted;
        }
    }
}