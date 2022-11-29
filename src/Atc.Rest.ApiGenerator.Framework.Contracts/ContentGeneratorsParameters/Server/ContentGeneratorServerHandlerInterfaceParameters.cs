namespace Atc.Rest.ApiGenerator.Framework.Contracts.ContentGeneratorsParameters.Server;

public record ContentGeneratorServerHandlerInterfaceParameters(
    string Namespace,
    string ApiGroupName,
    string OperationName,
    string Description,
    string InterfaceName,
    string ResultName,
    string? ParameterName);