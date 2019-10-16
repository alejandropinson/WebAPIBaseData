## 1. Create a new library

```javascript
\> dotnet new classlib
```

## 2. Change dotnet version in csproj

from

    <TargetFramework>netstandard2.0</TargetFramework>

to

    <TargetFramework>netstandard2.1</TargetFramework>

## 3. Add dependencies

```javascript
\> dotnet add Microsoft.EntityFrameworkCore.InMemory
\> dotnet add Microsoft.EntityFrameworkCore.Design
```
