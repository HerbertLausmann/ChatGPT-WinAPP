# ChatGPT WinAPP

ChatGPT WinAPP is a desktop application that embeds ChatGPT WebPage for easy use.
It also, solves some errors that you might be facing on the site like the error bellow:

_"An error occurred. If this issue persists please contact us through our help center at help.openai.com"_

## Installation

Download the last release by [clicking here](https://pip.pypa.io/en/stable/) and follow the setup steps.

## How it works?

This is a simple .Net Framework 4.7 WPF application that embeds the ChatGPT website through a CEFSharp WebBrowser Control.

CEFSharp is the most popular Chromium Wrapper for .Net Framework.

## The workaround for ChatGPT error mentioned above

It comes out running ChatGPT on Microsoft Edge and Google Chrome, for a unknown reason, in some desktop computers results on the error mentioned before.

The workaround that I've found was to change de WebBrowser User Agent to Mozilla/Gecko. Then, it started working fine.
