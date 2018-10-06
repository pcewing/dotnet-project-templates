# dotnet-project-templates

This repository contains project templates that can be used to create new
projects using the `dotnet` command line tool.

## Example Usage

In *bash* (Or *Git Bash* on Windows):
```bash
git clone https://github.com/pcewing/dotnet-project-templates templates
dotnet new --install templates/MvvmLightNet462
mkdir EmployeeDatabase && cd EmployeeDatabase
dotnet new mvvmlight462
```
