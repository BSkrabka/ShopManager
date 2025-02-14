using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "MSTestv2")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("SM.Core")]
[assembly: PexInstrumentAssembly("System.Linq.Expressions")]
[assembly: PexInstrumentAssembly("System.Collections")]
[assembly: PexInstrumentAssembly("System.Linq")]
[assembly: PexInstrumentAssembly("SM.Lib.Helpers")]
[assembly: PexInstrumentAssembly("SM.Data.Models")]
[assembly: PexInstrumentAssembly("Microsoft.Extensions.DependencyInjection.Abstractions")]
[assembly: PexInstrumentAssembly("SM.Data")]
[assembly: PexInstrumentAssembly("SM.Core.Models")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Linq.Expressions")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Collections")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Linq")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "SM.Lib.Helpers")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "SM.Data.Models")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.Extensions.DependencyInjection.Abstractions")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "SM.Data")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "SM.Core.Models")]

