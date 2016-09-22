using System;
using System.Text.RegularExpressions;

namespace Terminals.Network.DNS
{
    /// <summary>
    ///     Represents a DNS Question, comprising of a domain to query, the type of query (QTYPE) and the class
    ///     of query (QCLASS). This class is an encapsulation of these three things, and extensive argument checking
    ///     in the constructor as this may well be created outside the assembly (public protection)
    /// </summary>
    [Serializable]
    public class Question
    {
        // A question is these three things combined
        private readonly DnsClass _dnsClass;
        private readonly DnsType _dnsType;
        private readonly string _domain;

        /// <summary>
        ///     Construct the question from parameters, checking for safety
        /// </summary>
        /// <param name="domain"> the domain name to query eg. bigdevelopments.co.uk </param>
        /// <param name="dnsType"> the QTYPE of query eg. DnsType.MX </param>
        /// <param name="dnsClass"> the CLASS of query, invariably DnsClass.IN </param>
        public Question(string domain, DnsType dnsType, DnsClass dnsClass)
        {
            // check the input parameters
            if (domain == null) throw new ArgumentNullException("domain");

            // do a sanity check on the domain name to make sure its legal
            if (domain.Length == 0 || domain.Length > 255 ||
                !Regex.IsMatch(domain, @"^[a-z|A-Z|0-9|-|_]{1,63}(\.[a-z|A-Z|0-9|-|_]{1,63})+$"))
            {
                // domain names can't be bigger tan 255 chars, and individal labels can't be bigger than 63 chars
                throw new ArgumentException("The supplied domain name was not in the correct form.", "domain");
            }

            // sanity check the DnsType parameter
            if (!Enum.IsDefined(typeof(DnsType), dnsType) || dnsType == DnsType.None)
            {
                throw new ArgumentOutOfRangeException("dnsType", "The supplied dns type is not a valid value.");
            }

            // sanity check the DnsClass parameter
            if (!Enum.IsDefined(typeof(DnsClass), dnsClass) || dnsClass == DnsClass.None)
            {
                throw new ArgumentOutOfRangeException("dnsClass", "The supplied dns class is not a valid value.");
            }

            // just remember the values
            this._domain = domain;
            this._dnsType = dnsType;
            this._dnsClass = dnsClass;
        }

        /// <summary>
        ///     Construct the question reading from a DNS Server response. Consult RFC1035 4.1.2
        ///     for byte-wise details of this structure in byte array form
        /// </summary>
        /// <param name="pointer"> a logical pointer to the Question in byte array form </param>
        public Question(Pointer pointer)
        {
            // extract from the message
            this._domain = pointer.ReadDomain();
            this._dnsType = (DnsType)pointer.ReadShort();
            this._dnsClass = (DnsClass)pointer.ReadShort();
        }

        // expose them read/only to the world
        public string Domain
        {
            get { return this._domain; }
        }

        public DnsType Type
        {
            get { return this._dnsType; }
        }

        public DnsClass Class
        {
            get { return this._dnsClass; }
        }
    }
}