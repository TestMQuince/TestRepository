FROM build AS test
LABEL test=true
RUN dotnet test -c Release --results-directory /testresults --logger "trx;LogFileName=test_results.trx" MQuince.Services.Tests/MQuince.Services.Tests.csproj
