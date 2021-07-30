using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class BoardName
    {
        public BoardName()
        {
            BoardLines = new HashSet<BoardLine>();
            BoardNamePeople = new HashSet<BoardNamePerson>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Mindex { get; set; }
        public long ProjectId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string ColorId { get; set; }

        public virtual ICollection<BoardLine> BoardLines { get; set; }
        public virtual ICollection<BoardNamePerson> BoardNamePeople { get; set; }
    }
}
