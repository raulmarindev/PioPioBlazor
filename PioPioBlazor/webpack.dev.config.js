const MiniCssExtractPlugin = require('mini-css-extract-plugin');
const path = require('path');

module.exports = {
    mode: 'development',
    entry: {
        interop: './js/interop.js',
        site: './css/site.css',
    },
    output: {
        filename: '[name].js',
        path: path.resolve(__dirname, 'wwwroot'),
    },
    module: {
        rules: [
            {
                test: /\.css$/,
                use: [
                    MiniCssExtractPlugin.loader,
                    {
                        loader: 'css-loader',
                        options: {
                            importLoaders: 1
                        }
                    },
                    {
                        loader: 'postcss-loader',
                        options: {
                            plugins: (loader) => [
                                require('tailwindcss'),
                                require('autoprefixer')({}),
                                require('postcss-import')({ root: loader.resourcePath }),
                                require('postcss-preset-env')(),
                            ],
                            minimize: false
                        },
                    }
                ],
            },
        ],
    },
    plugins: [
        new MiniCssExtractPlugin({
            filename: './css/[name].css',
        }),
    ],
};