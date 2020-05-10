<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/raulmarindev/PioPioBlazor">
    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 100 100"><text y=".9em" font-size="70">🐔</text></svg>
  </a>

  <h3 align="center">Pío Pío</h3>

  <p align="center">
    Check out the best tweets on your Twitter Home Timeline!
    <br />
    <a href="https://github.com/raulmarindev/PioPioBlazor"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://pio.azurewebsites.net/">View Demo</a>
    ·
    <a href="https://github.com/raulmarindev/PioPioBlazor/issues">Report Bug</a>
    ·
    <a href="https://github.com/raulmarindev/PioPioBlazor/issues">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
## Table of Contents

* [About the Project](#about-the-project)
  * [Built With](#built-with)
<!--
* [Getting Started](#getting-started)
  * [Prerequisites](#prerequisites)
  * [Installation](#installation)
* [Usage](#usage)
-->
* [Roadmap](#roadmap)
* [Contributing](#contributing)
* [License](#license)
* [Contact](#contact)
* [Acknowledgements](#acknowledgements)



<!-- ABOUT THE PROJECT -->
## About The Project

[![Product Name Screen Shot][product-screenshot]](https://pio.azurewebsites.net)

This is a small demo project I've built to learn a bit about [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) and try it out. It's a simple website that, at the moment, shows the
tweets in my Home timeline and allows the user to filter the tweets by language of the tweet and by tag.

The tweets are retrieved from the [Twitter API](https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-home_timeline) through the use of [LinqToTwitter](https://github.com/JoeMayo/LinqToTwitter) (a LINQ provider for the Twitter micro-bloggin service). Normally, I don't have much time to
spend on Twitter so I wanted a quick way to see what the best tweets in my Timeline are (meaning the most reacted to tweets from those I'm following.)
The Tweets a user can see at a time are limited by the [Twitter API](https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-home_timeline).

A list of commonly used resources that I find helpful are listed in the acknowledgements.

### Built With
These are the main frameworks and tools I've used to build this project:
* [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-3.1)
* [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
* [Tailwind CSS](https://tailwindcss.com/)
* [webpack](https://webpack.js.org/)
* [yarn](https://yarnpkg.com/)


<!-- GETTING STARTED -->
<!--
## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

### Prerequisites

This is an example of how to list things you need to use the software and how to install them.
* npm
```sh
npm install npm@latest -g
```

### Installation

1. Get a free API Key at [https://example.com](https://example.com)
2. Clone the repo
```sh
git clone https://github.com/your_username_/Project-Name.git
```
3. Install NPM packages
```sh
npm install
```
4. Enter your API in `config.js`
```JS
const API_KEY = 'ENTER YOUR API';
```
-->



<!-- USAGE EXAMPLES -->
<!--
## Usage

Use this space to show useful examples of how a project can be used. Additional screenshots, code examples and demos work well in this space. You may also link to more resources.

_For more examples, please refer to the [Documentation](https://example.com)_
-->

<!-- ROADMAP -->
## Roadmap

See the [open issues](https://github.com/raulmarindev/PioPioBlazor/issues) for a list of proposed features (and known issues).



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.



<!-- CONTACT -->
## Contact

Raúl Marín - [@raulmarindev](https://twitter.com/raulmarindev) - email@raulmarin.dev

Project Link: [https://github.com/raulmarindev/PioPioBlazor](https://github.com/raulmarindev/PioPioBlazor)



<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
* [Img Shields](https://shields.io)
* [Autoprefixer](https://autoprefixer.github.io/)
* [PostCss](https://postcss.org/)
* [css-loader](https://webpack.js.org/loaders/css-loader/)
* [cssnano](https://cssnano.co/)
* [Visual Studio 2019](https://visualstudio.microsoft.com/vs/)
* [Azure App Service](https://azure.microsoft.com/en-us/services/app-service/)


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/raulmarindev/PioPioBlazor.svg?style=flat-square
[contributors-url]: https://github.com/raulmarindev/PioPioBlazor/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/raulmarindev/PioPioBlazor.svg?style=flat-square
[forks-url]: https://github.com/raulmarindev/PioPioBlazor/network/members
[stars-shield]: https://img.shields.io/github/stars/raulmarindev/PioPioBlazor.svg?style=flat-square
[stars-url]: https://github.com/raulmarindev/PioPioBlazor/stargazers
[issues-shield]: https://img.shields.io/github/issues/raulmarindev/PioPioBlazor.svg?style=flat-square
[issues-url]: https://github.com/raulmarindev/PioPioBlazor/issues
[license-shield]: https://img.shields.io/github/license/raulmarindev/PioPioBlazor.svg?style=flat-square
[license-url]: https://github.com/raulmarindev/PioPioBlazor/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/raulmarindev
[product-screenshot]: images/screenshot.png
