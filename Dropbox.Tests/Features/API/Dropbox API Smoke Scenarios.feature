﻿@API
Feature: Dropbox API Smoke Scenarios

Dropbox API Smoke Scenarios

@Smoke @Get
Scenario: Get all files
	When I try to get list of all existing files
	Then I should get valid list of files

@Smoke @Upload
Scenario: Upload a file
	Given I have 'MyPdf.pdf' file to upload
	When I upload the file
	| Path                    | Mode | AutoRename | Mute  |
	| /MyNewFolder/MyFile.pdf | add  | true       | false |
	Then I should be able to get file info
	| Name       |
	| MyFile.pdf |
