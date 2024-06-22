using CommonTypes;
using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.Metadata;
using System.Text;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // works
            Person person = new Person() { Name = "Test" };

            // throws
            // Could not load type 'System.Runtime.CompilerServices.RequiredMemberAttribute' from assembly 'BclTest.BclTypes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'.
            //
            //  Stack Trace: 
            //    ModuleHandle.ResolveType(QCallModule module, Int32 typeToken, IntPtr * typeInstArgs, Int32 typeInstCount, IntPtr * methodInstArgs, Int32 methodInstCount, ObjectHandleOnStack type)
            //    ModuleHandle.ResolveTypeHandle(Int32 typeToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
            //    RuntimeModule.ResolveType(Int32 metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
            //    CustomAttribute.FilterCustomAttributeRecord(MetadataToken caCtorToken, MetadataImport & scope, RuntimeModule decoratedModule, MetadataToken decoratedToken, RuntimeType attributeFilterType, Boolean mustBeInheritable, ListBuilder`1 & derivedAttributes, RuntimeType & attributeType, IRuntimeMethodInfo & ctorWithParameters, Boolean & isVarArg)
            //    CustomAttribute.IsCustomAttributeDefined(RuntimeModule decoratedModule, Int32 decoratedMetadataToken, RuntimeType attributeFilterType, Int32 attributeCtorToken, Boolean mustBeInheritable)
            //    CustomAttribute.IsDefined(RuntimeType type, RuntimeType caType, Boolean inherit)
            //    StackTrace.ToString(TraceFormat traceFormat, StringBuilder sb)
            //    StackTrace.ToString(TraceFormat traceFormat)
            //    Exception.get_StackTrace()
            string xml = @"<Person><Name>John Doe</Name></Person>";
            Person personX = Person.DeserializeFromXml(xml);
            Console.WriteLine(personX.Name);
        }
    }
}