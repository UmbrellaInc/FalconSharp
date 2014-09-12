# FalconSharp

FalconSharp is a client library targeting .NET 4.5 (and above) that interacts with the [Falcon Social](http://www.falconsocial.com/) API.

## Usage examples

Get the social content from the first channel of the associated organisation account:

	var falcon = new FalconClient("api_key");
	var channels = falcon.GetChannels();
	var content = falcon.GetContent(channels.Items.First().Id, limit: 10, offset:100);

## Supported Platforms

* .NET 4.5 (Desktop / Server)

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
