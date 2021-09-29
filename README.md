# DAVE

CODIFICATION PROGRAM – (Digital Audio for Visual Encryption)

Serial KEY : DRSE-AETD-VGES-0706-EIR-UITE-XGGA-ESGO-BGPA-ALED-2508

PRIMARY LENGUAGE:	
	The used Alphabet const of 27 letters, numbers from 0 to 9 and some of the most used special characters. The user will not be able to see this manual, or the main code in the program. There are 5 levels of encryption, also how they work is included in this manual. Nevertheless, it is a must to have the program for some of the procedures that involve the de-codification.
Parameters:
•	Main code: You can see the main codes of each character included in the program. Refer to “A0 FORM”

•	non-variable: This parameter means that the code will not change during the codification process.

•	variable: This parameter means that the code will change during the codification process. Refer to “A1 FORM”

•	inverse variable: This parameter means that the code will inverse its content. Refer to “A2 FORM”

•	suite: This parameter adds an extra-method of codification, it is important that both, the coder program and the de-coder program have the suite version of the program running.  

General Descriptions 
level 1:
•	Vowels 	:	20 code length. /non-variable 
•	Consonants	:	15 code length. /non-variable
•	Numbers 	:	10 code length. /non-variable
•	Characters	:	no encryption. 
Level 2:
•	Vowels 	:	20 code length. /variable
•	Consonants	:	15 code length. /non-variable
•	Numbers 	:	10 code length. /non-variable
•	Characters	:	10 code length. /non-variable
Level 3:
•	Vowels 	:	1 code length /inverse variable
•	Consonants	:	1 code length /inverse variable
•	Numbers 	:	1 code length /inverse variable
•	Characters	:	1 code length /non-variable
Level 4:	IN DEVELOPMENT
•	Vowels 	:	 code length /variable - cases
•	Consonants	:	 code length /variable 
•	Numbers 	:	 code length /variable - cases
•	Characters	:	 code length /non-variable


Level 4 is ONLY AVAILABLE in suite mode.


Specific Descriptions

Level 1______________________________________________________

This level includes basic encryption algorithms that change the original value into a specific code (A0 FORM). The algorithm will remove the brackets and punctuation marks to concatenate the values in a single line without spaces. Depending on the latest character, “.” For uppercase and “-” for lowercase. Example:

The program takes only the middle part (between punctuation and brackets), 10 characters for vowels, 5 characters for consonants and 8 characters for numbers. Characters in this level are not encrypted.

level 2______________________________________________________

This level is pretty similar to the previous one. Its characteristic is that vowels can change its value between 3 different codes. (A1 FORM). Encryption for Special Characters are available on this level (A0 FORM).


The program takes only the middle part (between punctuation and brackets), 10 characters for vowels, 5 characters for consonants, 8 characters for numbers and 6 characters for special Characters.

level 3______________________________________________________

This level change inversely the characters to identify the character. (A2 FORM)

Engine____________________________________________

This Algorithm is the way the message can be visible and how it is going to be read. It was made using NAudio Library for C#.

DAVE Engine is a TFFT analyzer, which can read, collect an graph the digital audio’s frequency spectrum.

It is high recommended to not change the technic values of the Analyzer in order to make it sure and easy to use. CHANGE THEM ONLY IF YOU KNOW WHAT YOU ARE DOING. The Engine will work perfectly under the specific set-up configuration.

