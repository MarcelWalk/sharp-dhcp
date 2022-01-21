# DHCP
## Helpful Links
- [Dynamic Host Configuration Protocol](http://www.networksorcery.com/enp/protocol/dhcp.htm#Boot%20filename)
    - Message Format
    - Description Of Message Contents
- [DHCP Message Format](http://www.tcpipguide.com/free/t_DHCPMessageFormat.htm)
    - Message Format
    - Description Of Message Contents
- [Wikipedia DHCP](https://en.wikipedia.org/wiki/Dynamic_Host_Configuration_Protocol)
    - General Overview
    - Message Format Of Most Important Messages
- [Wikipedia Octet](https://en.wikipedia.org/wiki/Octet_(computing))
    - What Is A Octet
- [Understanding the Basic Operations of DHCP](https://www.netmanias.com/en/post/techdocs/5998/dhcp-network-protocol/understanding-the-basic-operations-of-dhcp)
    - Message Formats (Including Release)
- [RFC2131](https://datatracker.ietf.org/doc/html/rfc2131#section-2)
    - Technical Documentation
    - Message Format
    - Message Section Sizes
    - Description Of Message Contents

## Message Types / Operations
- Discovery
    - Client -> Server
- Offer
    - Server -> Client
- Request
    - Client -> Server
- Acknowledgement
    - Server -> Client
- Information
    - **Optional**
    - IPv6 Specific
- Releasing
    - **Optional**
    - Client -> Server

## Procedures / Scenarios
- IP Address Allocation/Lease Procedure
    - Discover
    - Offer
    - Request
    - Acknowledge
- IP Address Renewal Procedure
    - Request
    - Acknowledge
- IP Address Release Procedure
    - Release