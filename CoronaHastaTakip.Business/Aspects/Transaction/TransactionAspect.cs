using Castle.DynamicProxy;
using CoronaHastaTakip.Business.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace CoronaHastaTakip.Business.Aspects.Transaction
{
    public class TransactionAspect: MethodInterception
    {
        public override void Intercept(IInvocation invocation)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    invocation.Proceed();
                    transaction.Complete();
                }
                catch (Exception e)
                {
                    transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
