using System.Collections.Generic;
using System.Linq;
using Fonfapres.App.Domain;

namespace Fonfapres.App.Data
{
    public class AccountRepo : IAccountRepo
    {
        private readonly AppContext _appContext;

        public AccountRepo(AppContext appContext)
        {
            _appContext = appContext;
        }

        Account IAccountRepo.AddAccount(Account account)
        {
            var accountAdded = _appContext.Accounts.Add(account);
            _appContext.SaveChanges();
            return accountAdded.Entity;
        }

        void IAccountRepo.DeleteAccount(int idAccount)
        {
            var accountFound = _appContext.Accounts.FirstOrDefault(p => p.Id==idAccount); //Revisar busqueda de Id por cedula, pero esta como string no int
            if (accountFound == null)
                return;
            _appContext.Accounts.Remove(accountFound);
            _appContext.SaveChanges();
        }

        IEnumerable<Account> IAccountRepo.GetAllAccounts()
        {
            return _appContext.Accounts;
        }

        Account IAccountRepo.GetAccount(int idAccount)
        {
            return _appContext.Accounts.FirstOrDefault(p => p.Id == idAccount);
        }

        Account IAccountRepo.UpdateAccount(Account account)
        {
            var accountFound = _appContext.Accounts.FirstOrDefault(p => p.Id == account.Id);
            if(accountFound!=null)
            {
                accountFound.code = account.code;
                accountFound.balance = account.balance;
                accountFound.typeAccount = account.typeAccount;

                _appContext.SaveChanges();
            }

            return accountFound;
        }
    }
}