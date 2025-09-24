using NSubstitute;
using Microsoft.Extensions.Configuration;
using Library.Infrastructure.Data;
using Library.ApplicationCore;
using Library.ApplicationCore.Entities;
using Xunit;

namespace UnitTests.Infrastructure.JsonLoanRepository {
    public class GetLoanTest {
        private readonly ILoanRepository _mockLoanRepository;
        private readonly JsonLoanRepository _jsonLoanRepository;
        private readonly IConfiguration _configuration;
        private readonly JsonData _jsonData;

        public GetLoanTest() {
            _mockLoanRepository = Substitute.For<ILoanRepository>();
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true)
                .Build();
            _jsonData = new JsonData(_configuration);
            _jsonLoanRepository = new JsonLoanRepository(_jsonData);
        }

        [Fact(DisplayName = "JsonLoanRepository.GetLoan: Returns loan when loan ID exists")]
        public async Task GetLoan_ReturnsLoan_WhenLoanIdExists() {
            // Arrange
            int existingLoanId = 1; // Loan ID 1 exists in Loans.json
            var expectedLoan = new Loan { Id = existingLoanId };
            _mockLoanRepository.GetLoan(existingLoanId).Returns(expectedLoan);

            // Act
            var actualLoan = await _jsonLoanRepository.GetLoan(existingLoanId);

            // Assert
            Assert.NotNull(actualLoan);
            Assert.Equal(expectedLoan.Id, actualLoan.Id);
        }
    }
}
