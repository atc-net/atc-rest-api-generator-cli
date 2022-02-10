namespace Atc.Rest.ApiGenerator.SyntaxGenerators.Api;

public class SyntaxGeneratorContractInterface : ISyntaxOperationCodeGenerator
{
    public SyntaxGeneratorContractInterface(
        ApiProjectOptions apiProjectOptions,
        IList<OpenApiParameter> globalPathParameters,
        OperationType apiOperationType,
        OpenApiOperation apiOperation,
        string focusOnSegmentName,
        bool hasParametersOrRequestBody)
    {
        this.ApiProjectOptions = apiProjectOptions ?? throw new ArgumentNullException(nameof(apiProjectOptions));
        this.GlobalPathParameters = globalPathParameters ?? throw new ArgumentNullException(nameof(globalPathParameters));
        this.ApiOperationType = apiOperationType;
        this.ApiOperation = apiOperation ?? throw new ArgumentNullException(nameof(apiOperation));
        this.FocusOnSegmentName = focusOnSegmentName ?? throw new ArgumentNullException(nameof(focusOnSegmentName));
        this.HasParametersOrRequestBody = hasParametersOrRequestBody;
    }

    public ApiProjectOptions ApiProjectOptions { get; }

    public IList<OpenApiParameter> GlobalPathParameters { get; }

    public OperationType ApiOperationType { get; }

    public OpenApiOperation ApiOperation { get; }

    public string FocusOnSegmentName { get; }

    public bool HasParametersOrRequestBody { get; }

    public CompilationUnitSyntax? Code { get; private set; }

    public bool GenerateCode()
    {
        var interfaceTypeName = "I" + ApiOperation.GetOperationName() + NameConstants.ContractHandler;
        var parameterTypeName = ApiOperation.GetOperationName() + NameConstants.ContractParameters;
        var resultTypeName = ApiOperation.GetOperationName() + NameConstants.ContractResult;

        // Create compilationUnit
        var compilationUnit = SyntaxFactory.CompilationUnit();

        // Create a namespace
        var @namespace = SyntaxProjectFactory.CreateNamespace(
            ApiProjectOptions,
            NameConstants.Contracts,
            FocusOnSegmentName);

        // Create interface
        var interfaceDeclaration = SyntaxInterfaceDeclarationFactory.Create(interfaceTypeName)
            .AddGeneratedCodeAttribute(ApiProjectOptions.ToolName, ApiProjectOptions.ToolVersion.ToString())
            .WithLeadingTrivia(SyntaxDocumentationFactory.CreateForInterface(ApiOperation, FocusOnSegmentName));

        // Create interface-method
        var methodDeclaration = SyntaxMethodDeclarationFactory.CreateInterfaceMethod(parameterTypeName, resultTypeName, HasParametersOrRequestBody)
            .WithLeadingTrivia(SyntaxDocumentationFactory.CreateForInterfaceMethod(GlobalPathParameters.Any() || ApiOperation.HasParametersOrRequestBody()));

        // Add using statement to compilationUnit
        compilationUnit = compilationUnit.AddUsingStatements(ProjectApiFactory.CreateUsingListForContractInterface());

        // Add interface-method to interface
        interfaceDeclaration = interfaceDeclaration.AddMembers(methodDeclaration);

        // Add the interface to the namespace.
        @namespace = @namespace.AddMembers(interfaceDeclaration);

        // Add namespace to compilationUnit
        compilationUnit = compilationUnit.AddMembers(@namespace);

        // Set code property
        Code = compilationUnit;
        return true;
    }

    public string ToCodeAsString()
    {
        if (Code is null)
        {
            GenerateCode();
        }

        if (Code is null)
        {
            return $"Syntax generate problem for contract-interface for apiOperation: {ApiOperation}";
        }

        return Code
            .NormalizeWhitespace()
            .ToFullString()
            .EnsureEnvironmentNewLines();
    }

    public LogKeyValueItem ToFile()
    {
        var area = FocusOnSegmentName.EnsureFirstCharacterToUpper();
        var interfaceName = "I" + ApiOperation.GetOperationName() + NameConstants.ContractHandler;
        var file = Util.GetCsFileNameForContract(ApiProjectOptions.PathForContracts, area, NameConstants.ContractInterfaces, interfaceName);
        return TextFileHelper.Save(file, ToCodeAsString());
    }

    public void ToFile(
        FileInfo file)
    {
        ArgumentNullException.ThrowIfNull(file);

        TextFileHelper.Save(file, ToCodeAsString());
    }

    public override string ToString()
        => $"OperationType: {ApiOperationType}, OperationName: {ApiOperation.GetOperationName()}, SegmentName: {FocusOnSegmentName}";
}