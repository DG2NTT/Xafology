using DevExpress.ExpressApp.DC;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Xafology.ExpressApp.Xpo.ValueMap
{
    public interface IXpoFieldValueReader
    {
        // lookup-property
        object GetMemberValue(IXPObject targetObj, IMemberInfo memberInfo, string value, bool createMember, bool cacheObject);
    }
}
