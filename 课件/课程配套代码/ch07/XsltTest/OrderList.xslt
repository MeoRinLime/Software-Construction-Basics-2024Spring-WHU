<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/ArrayOfOrder">
		<html>
			<head>
				<title>Orders</title>
			</head>
			<body>
				<ul>
					<xsl:for-each select="Order">
						<li>
              id：<xsl:value-of select="Id" />
              customer：<xsl:value-of select="Customer/Name" />
            </li>
            <ul>
              <xsl:for-each select="Details/OrderDetail">
                <li>
                  goods: <xsl:value-of select="Goods/Name" />
                  price:<xsl:value-of select="Goods/Price" />
                </li>
              </xsl:for-each>
            </ul>
					</xsl:for-each>
				</ul>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
