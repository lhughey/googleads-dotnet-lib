' Copyright 2014, Google Inc. All Rights Reserved.
'
' Licensed under the Apache License, Version 2.0 (the "License")
' you may not use this file except in compliance with the License.
' You may obtain a copy of the License at
'
'     http:'www.apache.org/licenses/LICENSE-2.0
'
' Unless required by applicable law or agreed to in writing, software
' distributed under the License is distributed on an "AS IS" BASIS,
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
' See the License for the specific language governing permissions and
' limitations under the License.

' Author: api.anash@gmail.com (Anash P. Oommen)

Imports Google.Api.Ads.AdWords.Lib
Imports Google.Api.Ads.AdWords.v201409

Imports System
Imports System.Collections.Generic
Imports System.IO

Namespace Google.Api.Ads.AdWords.Examples.VB.v201409

  Public Class SitelinksDataHolder
    Dim sitelinksFeedIdField As Long
    Dim linkTextFeedAttributeIdField As Long
    Dim linkFinalUrlFeedAttributeIdField As Long
    Dim sitelinkFeedItemIdsField As New List(Of Long)

    Public Property SitelinksFeedId As Long
      Get
        Return sitelinksFeedIdField
      End Get
      Set(ByVal value As Long)
        sitelinksFeedIdField = value
      End Set
    End Property

    Public Property LinkTextFeedAttributeId As Long
      Get
        Return linkTextFeedAttributeIdField
      End Get
      Set(ByVal value As Long)
        linkTextFeedAttributeIdField = value
      End Set
    End Property

    Public Property LinkFinalUrlFeedAttributeId As Long
      Get
        Return linkFinalUrlFeedAttributeIdField
      End Get
      Set(ByVal value As Long)
        linkFinalUrlFeedAttributeIdField = value
      End Set
    End Property

    Public Property SitelinkFeedItemIds As List(Of Long)
      Get
        Return sitelinkFeedItemIdsField
      End Get
      Set(ByVal value As List(Of Long))
        sitelinkFeedItemIdsField = value
      End Set
    End Property
  End Class

  ''' <summary>
  ''' This code example adds a sitelinks feed and associates it with a campaign.
  ''' To create a campaign, run AddCampaign.cs.
  '''
  ''' Tags: CampaignFeedService.mutate, FeedService.mutate, FeedItemService.mutate,
  ''' Tags: FeedMappingService.mutate
  ''' </summary>
  Public Class AddSitelinksUsingFeeds
    Inherits ExampleBase

    ''' <summary>
    ''' Main method, to run this code example as a standalone application.
    ''' </summary>
    ''' <param name="args">The command line arguments.</param>
    Public Shared Sub Main(ByVal args As String())
      Dim codeExample As New AddSitelinksUsingFeeds
      Console.WriteLine(codeExample.Description)
      Try
        Dim campaignId As Long = Long.Parse("INSERT_CAMPAIGN_ID_HERE")
        Dim feedName As String = "INSERT_FEED_NAME_HERE"
        codeExample.Run(New AdWordsUser, campaignId, feedName)
      Catch ex As Exception
        Console.WriteLine("An exception occurred while running this code example. {0}", _
            ExampleUtilities.FormatException(ex))
      End Try
    End Sub

    ''' <summary>
    ''' Returns a description about the code example.
    ''' </summary>
    Public Overrides ReadOnly Property Description() As String
      Get
        Return "This code example adds a sitelinks feed and associates it with a campaign."
      End Get
    End Property

    ''' <summary>
    ''' Runs the code example.
    ''' </summary>
    ''' <param name="user">The AdWords user.</param>
    ''' <param name="campaignId">Id of the campaign with which sitelinks are associated.
    ''' </param>
    ''' <param name="feedName">Name of the feed.</param>
    Public Sub Run(ByVal user As AdWordsUser, ByVal campaignId As Long, ByVal feedName As String)
      Dim siteLinksData As New SitelinksDataHolder
      createSitelinksFeed(user, siteLinksData, feedName)
      createSitelinksFeedItems(user, siteLinksData)
      createSitelinksFeedMapping(user, siteLinksData)
      createSitelinksCampaignFeed(user, siteLinksData, campaignId)
    End Sub

    Private Sub createSitelinksFeed( _
      ByVal user As AdWordsUser, ByVal sitelinksData As SitelinksDataHolder, _
      ByVal feedName As String)
      ' Get the FeedService.
      Dim feedService As FeedService = CType(user.GetService( _
          AdWordsService.v201409.FeedService), AdWords.v201409.FeedService)

      ' Create attributes.
      Dim textAttribute As New FeedAttribute
      textAttribute.type = FeedAttributeType.STRING
      textAttribute.name = "Link Text"
      Dim finalUrlAttribute As New FeedAttribute
      finalUrlAttribute.type = FeedAttributeType.URL_LIST
      finalUrlAttribute.name = "Link URL"

      ' Create the feed.
      Dim sitelinksFeed As New Feed
      sitelinksFeed.name = feedName
      sitelinksFeed.attributes = New FeedAttribute() {textAttribute, finalUrlAttribute}
      sitelinksFeed.origin = FeedOrigin.USER

      ' Create operation.
      Dim operation As New FeedOperation
      operation.operand = sitelinksFeed
      operation.operator = [Operator].ADD

      ' Add the feed.
      Dim result As FeedReturnValue = feedService.mutate(New FeedOperation() {operation})

      Dim savedFeed As Feed = result.value(0)

      sitelinksData.SitelinksFeedId = savedFeed.id
      Dim savedAttributes As FeedAttribute() = savedFeed.attributes
      sitelinksData.LinkTextFeedAttributeId = savedAttributes(0).id
      sitelinksData.LinkFinalUrlFeedAttributeId = savedAttributes(1).id
      Console.WriteLine("Feed with name {0} and ID {1} with linkTextAttributeId {2}" & _
          "linkFinalUrlAttributeId {3} was created.", savedFeed.name, savedFeed.id, _
          savedAttributes(0).id, savedAttributes(1).id)
    End Sub

    Private Sub createSitelinksFeedItems( _
        ByVal user As AdWordsUser, ByVal sitelinksData As SitelinksDataHolder)
      ' Get the FeedItemService.
      Dim feedItemService As FeedItemService = CType(user.GetService( _
          AdWordsService.v201409.FeedItemService), AdWords.v201409.FeedItemService)

      ' Create operations to add FeedItems.
      Dim home As FeedItemOperation = _
          newSitelinkFeedItemAddOperation(sitelinksData, "Home", "http://www.example.com")
      Dim stores As FeedItemOperation = _
          newSitelinkFeedItemAddOperation(sitelinksData, "Stores", "http://www.example.com/stores")
      Dim onSale As FeedItemOperation = _
          newSitelinkFeedItemAddOperation(sitelinksData, "On Sale", "http://www.example.com/sale")
      Dim support As FeedItemOperation = _
          newSitelinkFeedItemAddOperation(sitelinksData, "Support", _
              "http://www.example.com/support")
      Dim products As FeedItemOperation = _
          newSitelinkFeedItemAddOperation(sitelinksData, "Products", "http://www.example.com/prods")
      Dim aboutUs As FeedItemOperation = _
          newSitelinkFeedItemAddOperation(sitelinksData, "About Us", "http://www.example.com/about")

      Dim operations As FeedItemOperation() = _
          New FeedItemOperation() {home, stores, onSale, support, products, aboutUs}

      Dim result As FeedItemReturnValue = feedItemService.mutate(operations)
      For Each item As FeedItem In result.value
        Console.WriteLine("FeedItem with feedItemId {0} was added.", item.feedItemId)
        sitelinksData.SitelinkFeedItemIds.Add(item.feedItemId)
      Next
    End Sub

    ' See the Placeholder reference page for a list of all the placeholder types and fields.
    ' https://developers.google.com/adwords/api/docs/appendix/placeholders.html
    Private Const PLACEHOLDER_SITELINKS As Integer = 1

    ' See the Placeholder reference page for a list of all the placeholder types and fields.
    Private Const PLACEHOLDER_FIELD_SITELINK_LINK_TEXT As Integer = 1
    Private Const PLACEHOLDER_FIELD_SITELINK_FINAL_URL As Integer = 5

    Private Sub createSitelinksFeedMapping( _
       ByVal user As AdWordsUser, ByVal sitelinksData As SitelinksDataHolder)
      ' Get the FeedItemService.
      Dim feedMappingService As FeedMappingService = CType(user.GetService( _
          AdWordsService.v201409.FeedMappingService), AdWords.v201409.FeedMappingService)

      ' Map the FeedAttributeIds to the fieldId constants.
      Dim linkTextFieldMapping As New AttributeFieldMapping
      linkTextFieldMapping.feedAttributeId = sitelinksData.LinkTextFeedAttributeId
      linkTextFieldMapping.fieldId = PLACEHOLDER_FIELD_SITELINK_LINK_TEXT
      Dim linkFinalUrlFieldMapping As New AttributeFieldMapping
      linkFinalUrlFieldMapping.feedAttributeId = sitelinksData.LinkFinalUrlFeedAttributeId
      linkFinalUrlFieldMapping.fieldId = PLACEHOLDER_FIELD_SITELINK_FINAL_URL

      ' Create the FieldMapping and operation.
      Dim feedMapping As New FeedMapping
      feedMapping.placeholderType = PLACEHOLDER_SITELINKS
      feedMapping.feedId = sitelinksData.SitelinksFeedId
      feedMapping.attributeFieldMappings = _
          New AttributeFieldMapping() {linkTextFieldMapping, linkFinalUrlFieldMapping}
      Dim operation As New FeedMappingOperation
      operation.operand = feedMapping
      operation.operator = [Operator].ADD

      ' Save the field mapping.
      Dim result As FeedMappingReturnValue = _
          feedMappingService.mutate(New FeedMappingOperation() {operation})
      For Each savedFeedMapping As FeedMapping In result.value
        Console.WriteLine("Feed mapping with ID {0} and placeholderType {1} was saved for " & _
            "feed with ID {2}.", savedFeedMapping.feedMappingId, savedFeedMapping.placeholderType, _
            savedFeedMapping.feedId)
      Next
    End Sub

    Private Sub createSitelinksCampaignFeed(ByVal user As AdWordsUser, _
      ByVal sitelinksData As SitelinksDataHolder, ByVal campaignId As Long)
      ' Get the CampaignFeedService.
      Dim campaignFeedService As CampaignFeedService = CType(user.GetService( _
          AdWordsService.v201409.CampaignFeedService), AdWords.v201409.CampaignFeedService)

      ' Map the feed item ids to the campaign using an IN operation.
      Dim feedItemRequestContextOperand As New RequestContextOperand()
      feedItemRequestContextOperand.contextType = RequestContextOperandContextType.FEED_ITEM_ID

      Dim feedItemOperands As New List(Of FunctionArgumentOperand)()
      For Each feedItemId As Long In sitelinksData.SitelinkFeedItemIds
        Dim feedItemOperand As New ConstantOperand()
        feedItemOperand.longValue = feedItemId
        feedItemOperand.type = ConstantOperandConstantType.LONG
        feedItemOperands.Add(feedItemOperand)
      Next

      Dim feedItemfunction As New [Function]()
      feedItemfunction.lhsOperand = New FunctionArgumentOperand() {feedItemRequestContextOperand}
      feedItemfunction.operator = FunctionOperator.IN
      feedItemfunction.rhsOperand = feedItemOperands.ToArray()

      ' Optional: to target to a platform, define a function and 'AND' it with
      ' the feed item ID link:
      Dim platformRequestContextOperand As New RequestContextOperand()
      platformRequestContextOperand.contextType = RequestContextOperandContextType.DEVICE_PLATFORM

      Dim platformOperand As New ConstantOperand()
      platformOperand.stringValue = "Mobile"
      platformOperand.type = ConstantOperandConstantType.STRING

      Dim platformFunction As New [Function]()
      platformFunction.lhsOperand = New FunctionArgumentOperand() {platformRequestContextOperand}
      platformFunction.operator = FunctionOperator.EQUALS
      platformFunction.rhsOperand = New FunctionArgumentOperand() {platformOperand}

      ' Combine the two functions using an AND operation.
      Dim feedItemFunctionOperand As New FunctionOperand()
      feedItemFunctionOperand.value = feedItemfunction

      Dim platformFunctionOperand As New FunctionOperand()
      platformFunctionOperand.value = platformFunction

      Dim combinedFunction As New [Function]()
      combinedFunction.operator = FunctionOperator.AND
      combinedFunction.lhsOperand = New FunctionArgumentOperand() { _
          feedItemFunctionOperand, platformFunctionOperand}

      Dim campaignFeed As New CampaignFeed()
      campaignFeed.feedId = sitelinksData.SitelinksFeedId
      campaignFeed.campaignId = campaignId
      campaignFeed.matchingFunction = combinedFunction
      ' Specifying placeholder types on the CampaignFeed allows the same feed
      ' to be used for different placeholders in different Campaigns.
      campaignFeed.placeholderTypes = New Integer() {PLACEHOLDER_SITELINKS}

      Dim operation As New CampaignFeedOperation
      operation.operand = CampaignFeed
      operation.operator = [Operator].ADD
      Dim result As CampaignFeedReturnValue = _
          campaignFeedService.mutate(New CampaignFeedOperation() {operation})
      For Each savedCampaignFeed As CampaignFeed In result.value
        Console.WriteLine("Campaign with ID {0} was associated with feed with ID {1}", _
            savedCampaignFeed.campaignId, savedCampaignFeed.feedId)
      Next
    End Sub

    Function newSitelinkFeedItemAddOperation(ByVal sitelinksData As SitelinksDataHolder, _
        ByVal text As String, ByVal finalUrl As String) As FeedItemOperation
      ' Create the FeedItemAttributeValues for our text values.
      Dim linkTextAttributeValue As New FeedItemAttributeValue
      linkTextAttributeValue.feedAttributeId = sitelinksData.LinkTextFeedAttributeId
      linkTextAttributeValue.stringValue = text
      Dim linkFinalUrlAttributeValue As New FeedItemAttributeValue
      linkFinalUrlAttributeValue.feedAttributeId = sitelinksData.LinkFinalUrlFeedAttributeId
      linkFinalUrlAttributeValue.stringValues = New String() {finalUrl}

      ' Create the feed item and operation.
      Dim item As New FeedItem
      item.feedId = sitelinksData.SitelinksFeedId
      item.attributeValues = _
          New FeedItemAttributeValue() {linkTextAttributeValue, linkFinalUrlAttributeValue}
      Dim Operation As New FeedItemOperation
      Operation.operand = item
      Operation.operator = [Operator].ADD
      Return Operation
    End Function
  End Class

End Namespace
