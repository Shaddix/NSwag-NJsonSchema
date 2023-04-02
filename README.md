# nswag-portable

[![npm version](https://badge.fury.io/js/nswag-portable.svg)](https://www.npmjs.org/package/nswag-portable) [![npm](https://img.shields.io/npm/dt/nswag-portable.svg)](https://www.npmjs.org/package/nswag-portable) [![MIT](https://img.shields.io/dub/l/vibe-d.svg)](https://opensource.org/licenses/MIT)

This project builds [NSwag](https://github.com/RicoSuter/NSwag) in self-contained mode, so it could be used without installing .NET.

Notice, that we build NSwag and NJsonSchema from NON-OFFICIAL repositories:

- NSwag: https://github.com/mccsoft/NSwag
- NJsonSchema: https://github.com/mccsoft/NJsonSchema

These repositories contains fixes for:

- Correct handling of `OneOf` statements (when there are more than one of them).
