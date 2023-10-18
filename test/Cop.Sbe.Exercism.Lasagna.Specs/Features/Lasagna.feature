Feature: Lucian's Luscious Lasagna

# Rule Extractor: 
## Array.from(
##    document.getElementsByClassName("summary-title")
##           ).map(e => e.firstChild)

# Scenario Extractor: 
## Array.from(
##        document.getElementsByClassName("--summary-name")
##            ).map(e => e.firstChild)

Rule: Define the expected oven time in minutes
Scenario: Expected minutes in oven

Rule: Calculate the remaining oven time in minutes
Scenario: Remaining minutes in oven after twenty five minutes
Scenario: Remaining minutes in oven after thirty three minutes

Rule: Calculate the preparation time in minutes
Scenario: Preparation time in minutes for multiple layers
Scenario: Preparation time in minutes for one layer

Rule: Calculate the elapsed time in minutes
Scenario: Elapsed time in minutes for one layer
Scenario: Elapsed time in minutes for multiple layers