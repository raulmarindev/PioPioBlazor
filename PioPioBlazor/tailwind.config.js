// tailwind.config.js
module.exports = {
    purge: {
        enabled: true,
        content: ['./Components/*', './Pages/*', './Shared/*'],
    },
    darkMode: false, // or 'media' or 'class'
    theme: {
        extend: {},
    },
    variants: {},
    plugins: [],
}