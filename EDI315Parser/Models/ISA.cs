public class ISA
{
    
    public string AuthorizationInformationQualifier { get; set; }
        public string AuthorizationInformation { get; set; }
   
    public string SecurityInformationQualifier { get; set; }
    public string SecurityInformation { get; set; }

    public string InterchangeSenderIdQualifier { get; set; }
    public string InterchangeSenderId { get; set; }
    public string InterchangeReceiverIdQualifier { get; set; }
    public string InterchangeReceiverId { get; set; }

    public string Date { get; set; }
 
    public string Time { get; set; }
    public string InterchangeControlStandardsIdentifier { get; set; }
    public string InterchangeControlVersionNumber { get; set; }
    public string InterchangeControlNumber { get; set; }

    public string AcknowledgmentRequested { get; set; }
    public string UsageIndicator { get; set; }
    public string ComponentElementSeparator { get; set; }
    public string DateTime { get; set; }
    
}