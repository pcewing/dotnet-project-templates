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

## Debug Notes

I was able to get into a state where I was unable to uninstall templates using
the following command:
```bash
dotnet new --uninstall /absolute/path/to/template
```

A last resort to remove installed project templates is to run the following:
```bash
dotnet new --debug:reinit
```

However, it was pointed out in
[dotnet/templating:Issue#1226](https://github.com/dotnet/templating/issues/1226)
that "This flag is not technically supported, may change / be removed in the
future."
