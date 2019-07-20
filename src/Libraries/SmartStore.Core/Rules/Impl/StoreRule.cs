﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStore.Rules.Impl
{
    [Rule("Store", FriendlyName = "Store", Scope = RuleScope.Cart, DisplayOrder = 0)]
    public class StoreRule : ListRuleBase<int>
    {
        protected override int GetValue(RuleContext context)
        {
            return context.Store.Id;
        }

        protected override RuleDescriptor GetRuleDescriptor()
        {
            return new RuleDescriptor
            {
                RuleType = RuleType.IntArray,
                SelectList = new RemoteRuleValueSelectList("Store") { Multiple = true },
                Constraints = new IRuleConstraint[0]
            };
        }
    }
}
