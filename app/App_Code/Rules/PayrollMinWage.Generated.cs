using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using MyCompany.Data;

namespace MyCompany.Rules
{
	public partial class PayrollMinWageBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("PayrollMinWage", RowKind.New)]
        public void BuildNewPayrollMinWage()
        {
            UpdateFieldValue("isActive", ((1)));
        }
    }
}
