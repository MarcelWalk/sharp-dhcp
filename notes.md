# Architecture Notes

## Open Questions
- How to parse options efficiently
- Conversion to and from bytes
- What options should be implemented

## DhcpPacket
- OP (short)
- HTYPE (short)
- HLEN (short)
- HOPS (short)
  - Zero, used by relay agents
- XID (uint32)
- SECS (uint16)
- FLAGS (uint16)
- CIADDR (IP, custom parser)
- YIADDR (IP, custom parser)
- SIADDR (IP, custom parser)
- GIADDR (IP, custom parser)
- CHADDR (custom formatted string)
- SNAME (string)
- FILE (string)
- MAGIC COOKIE (uint32)
- OPTIONS (list of DhcpOption)

## DhcpOption
- OptionId (short)
- Length (short)
- Content (object)
- Type (enum?)
