# XE_HR_BackEndCommon
This contains common request handler classes and indirect referencing workflow logic shared by all server projects.
# Concepts Employed
* Request Handlers are classes that are commonly consumed by each server project which can be used to consume and direct domain events, business services, workflows, and other logic.
* Indirect References Transformers are classes where primary and foreign key numeric values are encrypted/decrypted so as not to expose sensitive values to calling applications.
* Indirect References Models are classes analogous to Entities which also include additional members to track encrypted/decrypted value representations, member mutability.
* Fluent Validators are classes implementing the 3rd party FluentValidation library to ensure values populating models=members correspond to specified limitations.
# 3rd Party Functionalities/Technologies/Libraries Employed
* [Microsoft DotNet 6.0 Software Development Kit](https://learn.microsoft.com/en-us/dotnet/csharp/)
* [FluentValidation](https://docs.fluentvalidation.net/en/latest/)
# Additional Notes
Fluent Validators are consumed by server and user interface projects.
