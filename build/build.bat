cd ../src/Api/MenteeApp.API

dotnet restore
dotnet build --no-restore
dotnet publish -o ../../../deploy