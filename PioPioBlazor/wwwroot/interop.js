/*
 * ATTENTION: The "eval" devtool has been used (maybe by default in mode: "development").
 * This devtool is neither made for production nor for readable output files.
 * It uses "eval()" calls to create a separate source file in the browser devtools.
 * If you are trying to read the output file, select a different devtool (https://webpack.js.org/configuration/devtool/)
 * or disable the default devtool with "devtool: false".
 * If you are looking for production-ready output files, see mode: "production" (https://webpack.js.org/configuration/mode/).
 */
/******/ (() => { // webpackBootstrap
/******/ 	var __webpack_modules__ = ({

/***/ "./js/interop.js":
/*!***********************!*\
  !*** ./js/interop.js ***!
  \***********************/
/***/ (() => {

eval("﻿window.clipboardCopy = {\r\n    copyText: function (text) {\r\n        navigator.clipboard.writeText(text).then(function () {\r\n            alert(\"Copied to clipboard!\");\r\n        })\r\n            .catch(function (error) {\r\n                alert(error);\r\n            });\r\n    }\r\n};\r\n\r\nwindow.tagSelectorComponent = {\r\n    getValue: function (element) {\r\n        return element.value;\r\n    },\r\n    setValue: function (element, value) {\r\n        element.value = value;\r\n    },\r\n    blur: function (element) {\r\n        element.blur();\r\n    }\r\n};\n\n//# sourceURL=webpack://pio-pio/./js/interop.js?");

/***/ })

/******/ 	});
/************************************************************************/
/******/ 	
/******/ 	// startup
/******/ 	// Load entry module and return exports
/******/ 	// This entry module can't be inlined because the eval devtool is used.
/******/ 	var __webpack_exports__ = {};
/******/ 	__webpack_modules__["./js/interop.js"]();
/******/ 	
/******/ })()
;