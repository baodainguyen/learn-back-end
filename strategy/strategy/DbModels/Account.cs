using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class Account
    {
        public Account()
        {
            AccountRoles = new HashSet<AccountRole>();
            ActionPeople = new HashSet<ActionPerson>();
            CrmFilters = new HashSet<CrmFilter>();
            CrmFiltersCrowds = new HashSet<CrmFiltersCrowd>();
            GoalPeople = new HashSet<GoalPerson>();
            SubMarketProductAccounts = new HashSet<SubMarketProductAccount>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActived { get; set; }
        public string ActiveValue { get; set; }
        public DateTime? LastLoginedDate { get; set; }
        public Guid? ResetPasswordValue { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Firm { get; set; }
        public string Department { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string TmpEmail { get; set; }
        public string ActiveInviteValue { get; set; }
        public string Theme { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string PageName { get; set; }
        public string Greeting { get; set; }
        public string SigningOff { get; set; }

        public virtual ICollection<AccountRole> AccountRoles { get; set; }
        public virtual ICollection<ActionPerson> ActionPeople { get; set; }
        public virtual ICollection<CrmFilter> CrmFilters { get; set; }
        public virtual ICollection<CrmFiltersCrowd> CrmFiltersCrowds { get; set; }
        public virtual ICollection<GoalPerson> GoalPeople { get; set; }
        public virtual ICollection<SubMarketProductAccount> SubMarketProductAccounts { get; set; }
    }
}
