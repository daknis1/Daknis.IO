# Daknis.IO

Wrappers around the .NET Standard libraries to provide interfaces that are useful for abstractions and testing.

## Installing

I am in the process of getting a code signing cert from Comodo. After I get that, this package will be available on nuget.org.

I (daknis1) work at Microsoft and brought these class wrappers and others into work. There is a possibility that these will be released through an official Microsoft channel, contributing to the `System.IO` namespace. If and when that occurs, I will be deprecating my library in favor of the Microsoft published ones, that will also likely be published by myself. Currently, there is no official support or coordination with the .NET team.

## Usage

### Use Dependency Injection

To benefit from the wrappers, you must inject the interface into the class. This is best used with a DI factory pattern or use in an application that leverages an IoC container.

By storing the dependency as the same name of the class it wraps, even if you import `System.IO`, you've shadows the underlying `System.IO.File` static class invocations, so you will always call the wrapper.

```
using Daknis.IO;
...
public class MyClass
{
	private readonly IFile File;

	public MyClass(ISvReader svReader)
	{
		SvReader = svReader ?? throw new ArgumentNullException(nameof(svReader));
	}

	public string ReadFile(string filePath)
	{
		string contents = string.Empty;

		if (File.Exists(filePath))
		{
			contents = File.ReadAllText(filePath);
		}

		return contents;
	}
}

```

Injecting allows you to write unit tests by mocking out returns. This saves the project from expensive test setup and breakdown that requires real files to be read and saved.

```
using Daknis.IO;
using Moq;
using xUnit;

public class MyClassTests
{
	private readonly Mock<IFile> MockFile;

	public MyClassTests()
	{
		MockFile = new Mock<IFile>();
		// Setup global mock returns
		MockFile.Setup(mock => mock.ReadAllText(It.IsAny<string>())).Returns("MockFile.ReadAllText.mock");
	}

	private MyClass GetMockedMyClass()
	{
		return new MyClass(MockFile.Object)
	}

	[Fact]
	public void ReadFile_FileExists()
	{
		// It returns the contents of the file

		// Setup local mock return
		MockFile.Setup(mock => mock.Exists(It.IsAny<string>())).Returns(true);

		MyClass myClass = GetMockedMyClass();
		string actual = myClass.ReadFile("filePath.fake");
		Assert.Equal("MockFile.ReadAllText.mock", actual);
		
		// It checks if the file exists
		MockFile.Verify(mock => mock.Exists("filePath.fake"), Times.Once);

		// It reads the file
		MockFile.Verify(mock => mock.ReadAllText("filePath.fake"), Times.Once);
	

	[Fact]
	public void ReadFile_FileDoesNotExists()
	{
		// It returns string.Empty

		// Setup local mock return
		MockFile.Setup(mock => mock.Exists(It.IsAny<string>())).Returns(false);

		MyClass myClass = GetMockedMyClass();
		string actual = myClass.ReadFile("filePath.fake");
		Assert.Equal(string.Empty, actual);

		// It checks if the file exists
		MockFile.Verify(mock => mock.Exists("filePath.fake"), Times.Once);

		// It doesn't read the file
		MockFile.Verify(mock => mock.ReadAllText("filePath.fake"), Times.Never);
	}
}
```

## Built With

* [.NET Standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) - Library code
* [.NET Core](https://aka.ms/netcore) - Test Environment
* [xUnit](https://xunit.github.io/) - Test Framework

## Versioning

We use [SemVer](http://semver.org/) for versioning.

## Authors

* **David Knise** - [daknis1](https://github.com/daknis1)

See also the list of [contributors](https://github.com/daknis1//contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.