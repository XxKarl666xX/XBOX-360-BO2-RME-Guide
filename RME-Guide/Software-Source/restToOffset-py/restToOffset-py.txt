#Dev___1_
while 1:
    # Step 1: Define the starting address from the RME exploit
    RMEstartAddress = 2203392528

    # Step 2: Define a function to convert hex to decimal
    def hex_to_decimal(hex_str):
        return int(hex_str, 16)

    # Step 3: Define a function to calculate the difference and convert to hex
    def calculate_difference_and_convert(hex_str):
        restToOffset = hex_to_decimal(hex_str)
        difference = restToOffset - RMEstartAddress
        return hex(difference)

    # get the offset from which the user wants restToOffset
    yourOffset=input("Your offset: 0x")
    result = calculate_difference_and_convert(yourOffset)
    print(f"restToOffset = {result.upper()}")
    print("possible code for RME.cpp: [input general look of RME command with custom value]")

    #end the script if user writes "end"
    endCheck = input("Type 'end' to end the script or press enter to calculate another 'restToOffset'... ")
    if endCheck == str("end"):
        break
