module.exports = {
    mode: 'production',
    entry: { style: './css/site.css' },
    module: {
        rules: [
            {
                test: /\.css$/,
                use: [
                    {
                        loader: 'postcss-loader',
                        options: {
                            ident: 'postcss',
                            plugins: (loader) => [
                                require('autoprefixer')({}),
                                require('postcss-import')({ root: loader.resourcePath }),
                                require('postcss-preset-env')(),
                                require('cssnano')({
                                    preset: 'default'
                                })
                            ],
                            minimize: false
                        },
                    }
                ],
            },
        ],
    },
};