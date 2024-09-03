﻿using Microsoft.AspNetCore.Components;

namespace KidsIdKit.Pages.info
{
    public class InfoHyperlink
    {
        //1. public static MissingChildrenMinnesotaWebsite()
        //{
        //https://missingchildrenmn.com/ https://missingchildrenmn.com/contact/
        //}

        public static MarkupString ContactTheNationalCenterForMissingAndExploitedChildren() {
            var userFriendlyPhoneLink = GetPhoneLink("1-800-843-5678");
            return (MarkupString)$"Contact the National Center for Missing and Exploited Children (NCMEC) at 1-800-THE-LOST ({userFriendlyPhoneLink}) to register your child";
        }

        public static MarkupString RunawayPhoneNumber() {
            var userFriendlyPhoneLink = GetPhoneLink("1-800-786-2929");
            return (MarkupString)$"1-888-RUNAWAY ({userFriendlyPhoneLink})";
        }
        // https://www.1800runaway.org/

        public static MarkupString RunYellPhoneNumber()
        {
            MarkupString userFriendly800PhoneLink = GetPhoneLink("1-888-786-9355");
            var userFriendlyPhoneLink = GetPhoneLink("1-612-334-9449");
            return (MarkupString)$"{userFriendlyPhoneLink} or 1-888-RUN-YELL ({userFriendly800PhoneLink})";
        }

        #region Helper method for other methods in this class
        private static MarkupString GetPhoneLink(string phoneNumber)
        {
            return HyperlinkHelper.PhoneNumberHelper.GetPhoneLink(phoneNumber);
        }
        #endregion
    }
}
