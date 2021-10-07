using System.Collections.Generic;
using Fonfapres.App.Domain;

namespace Fonfapres.App.Data
{
    public interface IAccountRepo
    {
        IEnumerable<Account> GetAllAccounts();

        Account AddAccount(Account account);

        Account UpdateAccount(Account account);

        void DeleteAccount(int idAccount);

        Account GetAccount(int idAccount);
    }
}