# FalconSharp

FalconSharp is an unofficial client library for accessing the beta *Content API* from [Falcon Social](http://www.falconsocial.com/).


## Usage examples

List all of the social channels from the associated organisation account:

	var falcon = new FalconClient("api_key");
	var channels = falcon.GetChannels();
	foreach (var channel in channels.Items)
	{
		Console.WriteLine(channel.Name);
	}

Get paged social content items, (limited to 10 and after 100) from a selected social channel:

	var falcon = new FalconClient("api_key");
	var content = falcon.GetContent("channel_name", limit: 10, offset:100);
	foreach (var item in content.Items)
	{
		Console.WriteLine("{0}: {1} - {2}", item.Network, item.Name, item.Message);
	}


## Supported Platforms

* .NET 4.5 (Desktop / Server)


## Getting Started

[FalconSharp is available on NuGet](https://www.nuget.org/packages/FalconSharp).

	Install-Package FalconSharp


## Build

If you prefer, you can compile FalconSharp yourself, you'll need:

* Visual Studio 2012 (or above)

To clone it locally click the "Clone in Windows" button above or run the following git commands.

	git clone https://github.com/UmbrellaInc/FalconSharp.git FalconSharp
	cd FalconSharp
	.\build.cmd


## Contact

Have a question?

* [Raise an issue](https://github.com/UmbrellaInc/FalconSharp/issues) on GitHub


## Contributing to this project

Anyone and everyone is welcome to contribute. Please take a moment to review the [guidelines for contributing](CONTRIBUTING.md).

* [Bug reports](CONTRIBUTING.md#bugs)
* [Feature requests](CONTRIBUTING.md#features)
* [Pull requests](CONTRIBUTING.md#pull-requests)


Special thanks go to [Matt Brailsford](https://github.com/mattbrailsford) for helping to develop this library.

## Copyright and License

Copyright &copy; 2014 Umbrella Inc

Licensed under the [MIT License](LICENSE.md)
