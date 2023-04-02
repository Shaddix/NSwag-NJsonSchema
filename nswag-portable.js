#!/usr/bin/env node
"use strict";

// Initialize
process.title = 'nswag';
console.log("NSwag NPM CLI");
var args = process.argv.splice(2, process.argv.length - 2).map(function (a) { return a.indexOf(" ") === -1 ? a : '"' + a + '"' }).join(" ");

var c = require('child_process');
var cmd = '"' + __dirname + '/bin/nswag-portable" ' + args;
var code = c.execSync(cmd, { stdio: [0, 1, 2] });
return;
