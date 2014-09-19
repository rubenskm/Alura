﻿using NHibernate;
using System.Web.Mvc;

namespace LojaWeb.Filters
{
	public class TransactionFilter : ActionFilterAttribute
	{
		private ISession session;
		public TransactionFilter(ISession session)
		{
			this.session = session;
		}
		public override void OnActionExecuting(ActionExecutingContext contexto)
		{
			session.BeginTransaction();
		}
		public override void OnActionExecuted(ActionExecutedContext contexto)
		{
			if (contexto.Exception == null)
			{
				session.Transaction.Commit();
			}
			else
			{
				session.Transaction.Rollback();
			}
			session.Close();
		}
	}
}