#!/usr/bin/env node
"use strict";
const os = require('os');

// Initialize
process.title = 'nswag';
console.log("NSwag NPM CLI");
var args = process.argv.splice(2, process.argv.length - 2).map(function (a) { return a.indexOf(" ") === -1 ? a : '"' + a + '"' }).join(" ");

const isMacOs = os.platform() === 'darwin';
const isMaxOsArm = isMacOs && os.arch()?.includes('arm');
const nswagPath = __dirname + '/bin/nswag-portable' + (isMacOs ? (isMaxOsArm ? '.mac.arm': '.mac') : '');

const fs = require('fs');
fs.chmodSync(nswagPath, '755');

var c = require('child_process');
var cmd = '"' + nswagPath + '" ' + args;
var code = c.execSync(cmd, { stdio: [0, 1, 2] });
return;
