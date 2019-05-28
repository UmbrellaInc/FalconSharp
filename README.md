# FalconSharp

[![No Maintenance Intended](http://unmaintained.tech/badge.svg)](http://unmaintained.tech/)

FalconSharp is an unofficial client library for accessing the beta *Content API* from [Falcon Social](http://www.falconsocial.com/).


## Supported Platforms

* .NET 4.5 (Desktop / Server)


## Getting Started

### Installation

[FalconSharp is available on NuGet](https://www.nuget.org/packages/FalconSharp).

	Install-Package FalconSharp

### Manual build

If you prefer, you can compile the project yourself, you'll need:

* Visual Studio 2012 (or above)

To clone it locally click the "Clone in Windows" button above or run the following git commands.

	git clone https://github.com/UmbrellaInc/FalconSharp.git FalconSharp
	cd FalconSharp
	.\build.cmd


## Usage examples

List all of the social channels from the associated organisation account:

	var falcon = new FalconClient("api_key");
	var channels = falcon.GetChannels();
	foreach (var channel in channels.Items)
	{
		Console.WriteLine(channel.Name);
	}

Get paged social content items, (limited to 10) from a selected social channel:

	var falcon = new FalconClient("api_key");
	var content = falcon.GetContent("channel_name", limit: 10);
	foreach (var item in content.Items)
	{
		Console.WriteLine("{0}: {1} - {2}", item.Network, item.Name, item.Message);
	}


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

Copyright &copy; 2014 Umbrella Inc and [other contributors](https://github.com/UmbrellaInc/FalconSharp/graphs/contributors)

Licensed under the [MIT License](LICENSE.md)

### Logo Credit

[Temp falcon](https://en.wikipedia.org/wiki/File:Temp_falcon.svg) by [Wilsonbiggs](https://en.wikipedia.org/wiki/User:Wilsonbiggs) - conv. Licensed under [CC BY-SA 3.0](http://creativecommons.org/licenses/by-sa/3.0/) via [Wikipedia](https://en.wikipedia.org/wiki/)
