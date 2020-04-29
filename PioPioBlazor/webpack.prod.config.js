const MiniCssExtractPlugin = require('mini-css-extract-plugin');
const Path = require('path');

module.exports = {
    mode: 'development',
    entry: {
        site: './css/site.css',
    },
    output: {
        filename: '[name].js',
        path: Path.resolve(__dirname, 'wwwroot'),
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
                                require('cssnano')({
                                    preset: 'default'
                                })
                            ],
                            minimize: true
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