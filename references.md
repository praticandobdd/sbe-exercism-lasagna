# Referências

## Ignorando pastas e arquivos no git

* <https://learn.microsoft.com/en-us/azure/devops/repos/git/ignore-files>

```bash

git rm --cached StrykerOutput 
git rm --cached bin
git rm --cached obj

git commit -m "Não rastrear arquivos gerados"

```

## Relatórios de qualidade 

```bash
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=./lcov.info ./test/Cop.Sbe.Exercism.Lasagna.Specs/
```

```bash
livingdoc test-assembly test/Cop.Sbe.Exercism.Lasagna.Specs/bin/Debug/net7.0/Cop.Sbe.Exercism.Lasagna.Specs.dll -t test/Cop.Sbe.Exercism.Lasagna.Specs/bin/Debug/net7.0/TestExecution.json
```

```bash
dotnet stryker --open-report
```

```bash
reportgenerator -reports:./test/Cop.Sbe.Exercism.Lasagna.Specs/lcov.info -targetdir:.coverage
```