﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dnlib.DotNet;
using Confuser.Core;

namespace Confuser.Renamer.References
{
    class TypeRefReference : INameReference<TypeDef>
    {
        TypeRef typeRef;
        TypeDef typeDef;
        public TypeRefReference(TypeRef typeRef, TypeDef typeDef)
        {
            this.typeRef = typeRef;
            this.typeDef = typeDef;
        }

        public bool UpdateNameReference(ConfuserContext context, INameService service)
        {
            typeRef.Namespace = typeDef.Namespace;
            typeRef.Name = typeDef.Name;
            return true;
        }

        public bool ShouldCancelRename()
        {
            return false;
        }
    }
}
